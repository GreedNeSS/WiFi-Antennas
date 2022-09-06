using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.BLL.Mappers;
using WiFi_Antennas.BLL.Infrastructure;
using WiFi_Antennas.BLL.Interfaces;
using WiFi_Antennas.DAL.Interfaces;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.BLL.Services
{
    public class AntennaService : IAntennaService
    {
        private IAntennaRepository repo;

        public AntennaService(IAntennaRepository repository)
        {
            repo = repository;
        }

        public async Task CreateAsync(AntennaDTO antenna)
        {
            try
            {
                await repo.Create(antenna.ToEntity());
            }
            catch (Exception)
            {
                throw new ValidationException("Произошла ошибка записи при созании новой антенны! " +
                    "Возможно антенна с таким IP уже существует.", "IP");
            }
        }

        public async Task DeleteAsync(int antennaId)
        {
            try
            {
                await repo.Delete((new AntennaDTO { Id = antennaId }).ToEntity());
            }
            catch (Exception)
            {
                throw new ValidationException("Антенны не существует или уже была удалена!", "Id");
            }
        }

        public async Task<AntennaDTO> GetAntennaAsync(int id)
        {
            Antenna? antenna = await repo.GetAntenna(id);

            if (antenna == null)
            {
                throw new ValidationException("Антенна не найдена", "");
            }

            return antenna.ToDTO();
        }

        public async Task<List<AntennaDTO>> GetAntennasAsync(int take, int skip, string ssid = "", string ip = "",
            string address = "", SortStateDTO sortState = SortStateDTO.IpAsc)
        {
            List<Antenna> antennas = await repo.GetAntennas(take, skip, ssid, ip, address, sortState.ToDAL());
            return antennas.Select(a => a.ToDTO()).ToList();
        }

        public async Task<int> GetCountAsync(string ssid = "", string ip = "", string address = "")
        {
            return await repo.GetCount(ssid, ip, address);
        }

        public async Task UpdateAsync(AntennaDTO antenna)
        {
            try
            {
                await repo.Update(antenna.ToEntity());
            }
            catch (Exception)
            {
                throw new ValidationException("Не удалось изменить антенну. Возможно антенна с таким IP уже существует.", "IP");
            }
        }
    }
}

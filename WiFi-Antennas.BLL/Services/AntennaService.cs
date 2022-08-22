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

        public void Create(AntennaDTO antenna)
        {
            try
            {
                repo.Create(antenna.ToEntity());
            }
            catch (Exception)
            {
                throw new ValidationException("Произошла ошибка записи при созании новой антенны!", "");
            }
        }

        public void Delete(int antennaId)
        {
            try
            {
                repo.Delete((new AntennaDTO { Id = antennaId }).ToEntity());
            }
            catch (Exception)
            {
                throw new ValidationException("Антенны не существует или уже была удалена!", "Id");
            }
        }

        public async Task<AntennaDTO> GetAntenna(int id)
        {
            Antenna? antenna = await repo.GetAntenna(id);

            if (antenna == null)
            {
                throw new ValidationException("Антенна не найдена", "");
            }

            return antenna.ToDTO();
        }

        public async Task<List<AntennaDTO>> GetAntennas(int take, int skip)
        {
            List<Antenna> antennas = await repo.GetAntennas(take, skip);
            return antennas.Select(a => a.ToDTO()).ToList();
        }

        public void Update(AntennaDTO antenna)
        {
            repo.Update(antenna.ToEntity());
        }
    }
}

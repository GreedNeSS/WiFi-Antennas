const exampleModal = document.getElementById('exampleModal')
exampleModal.addEventListener('show.bs.modal', event => {
    const button = event.relatedTarget
    const recipient = button.getAttribute('data-delete-id')
    const form = exampleModal.querySelector('#formDelete')
    form.setAttribute('action', `/Home/Delete/${recipient}`)
})
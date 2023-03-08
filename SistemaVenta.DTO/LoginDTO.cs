namespace SistemaVenta.DTO
{
    public class LoginDTO
    {
        public string Correo { get; set; }
        public string Clave { get; set; }

        //TODO Encriptar la contraseña para poder mostrarla
    }
}

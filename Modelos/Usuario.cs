namespace LoginPractica.Modelos
{
    public class Usuario
    {      
        public int UsuarioId { get; set; }
        public required string Correo { get; set; }
        public required string ElPassword { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
    }
}

namespace AnalisisDeSistemas
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int idDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSal { get; set; }
        public bool condicion { get; set; }
    }
}

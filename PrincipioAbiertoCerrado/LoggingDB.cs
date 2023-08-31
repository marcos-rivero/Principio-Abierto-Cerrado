namespace PrincipioAbiertoCerrado
{
    public class LoggingDB : Logging
    {
        private readonly LoggingRepositorio _logginRepositorio;
        public LoggingDB() { 
            _logginRepositorio = new LoggingRepositorio();
        }

        public override void Fatal(string mensaje, Exception e)
        {
            base.Fatal(mensaje, e);
            _logginRepositorio.Guardar();
        }
    }
}

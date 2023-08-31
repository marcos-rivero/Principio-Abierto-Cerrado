using Serilog;

namespace PrincipioAbiertoCerrado
{
    public class Logging
    {
        private readonly LoggingRepositorio _loggingRepositorio;
        public Logging() { 
            _loggingRepositorio = new LoggingRepositorio();
        }
        public void Informacion(string mensaje)
        {
            Log.Information(mensaje);
            _loggingRepositorio.Guardar();
        }

        public void Error(string mensaje, Exception e)
        {
            Log.Error(mensaje, e);
            _loggingRepositorio.Guardar();
        }

        public virtual void Fatal(string mensaje, Exception e)
        {
            Log.Information(mensaje, e);
            _loggingRepositorio.Guardar();
        }
    }
}

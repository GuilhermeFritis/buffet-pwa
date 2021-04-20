using Buffet.RequestModels;

namespace Buffet.ViewModels.Acesso
{
    public class GenericViewModel
    {
        public string Msg { get; set; }

        public GenericViewModel(string msg)
        {
            Msg = msg;
        }
    }
}
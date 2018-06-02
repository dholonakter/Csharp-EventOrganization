using BuyTicketApp.Models;

namespace BuyTicketApp.Helper
{
    public interface ILogger
    {
        void LogMessage(ErrorType errorType,string message);
    }
}

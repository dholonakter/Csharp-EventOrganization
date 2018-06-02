namespace CampApp.Exception
{
    public class ParticipantNotAllowedException:System.Exception
    {
        public ParticipantNotAllowedException():base()
        {

        }
        public ParticipantNotAllowedException(string message):base(message)
        {
            
        }
    }
}

namespace Application.Common.Models.Log
{
    public class SeleniumLogDto
    {
        public string Message { get; set; }
        public DateTimeOffset SentOn { get; set; }

        public SeleniumLogDto(string message)
        {
            Message = message;

            SentOn = DateTimeOffset.Now;
        }
    }
}

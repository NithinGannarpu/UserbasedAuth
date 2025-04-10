namespace UserbasedAuth.Models.DTOs
{
    public class LoginResponseDTO
    {

        public object User { get; set; }
        public string Token { get; set; }
        public string message { get; set; }
        public bool isSuccess { get; set; }
    }
}

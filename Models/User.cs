using System.Text.Json.Serialization;

namespace APITest.Models {
    public class User {
        [JsonIgnore]
        public int Id { get; set; } 
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Passworld { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}

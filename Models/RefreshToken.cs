using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentifyAPI.Models
{
    [Table("refresh_tokens")]
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Token { get; set; } = null!;

        [Required]
        public int UsuarioId { get; set; }

        public DateTime ExpiresAt { get; set; }

        public bool Revoked { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuario? Usuario { get; set; }
    }
}

namespace nguyenthanhphuong_2122110515.Model
{
    public class User
    {
        public int Id { get; set; } // Sửa lỗi dấu chấm phẩy
        public string Username { get; set; } // Tên người dùng
        public string Email { get; set; } // Email
        public string Password { get; set; } // Mật khẩu (có thể hash)
    }
}

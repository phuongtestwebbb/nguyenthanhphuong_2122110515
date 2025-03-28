namespace nguyenthanhphuong_2122110515.Model
{
    public class Product
    {
        public int Id { get; set; } // Mã sản phẩm (Khóa chính)
        public string Name { get; set; } // Tên sản phẩm
        public string Description { get; set; } // Mô tả sản phẩm
        public decimal Price { get; set; } // Giá sản phẩm
        public int StockQuantity { get; set; } // Số lượng trong kho
        public string ImageUrl { get; set; } // Ảnh sản phẩm

        // Quan hệ với bảng khác (ví dụ: Category)
        public int CategoryId { get; set; } // Mã danh mục
    }
}

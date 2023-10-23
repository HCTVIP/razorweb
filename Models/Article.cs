using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RAZORWEB.Models
{
	public class Article
	{
		[Key]
		public int Id { get; set; }
		[StringLength(255, MinimumLength =5, ErrorMessage ="{0} phải dài từ {2} đến {1}")]
		[Required(ErrorMessage ="Trường dữ liệu {0} phải nhập")]
		[Column(TypeName = "nvarchar")]
		[DisplayName("Tiêu đề")]
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[Required(ErrorMessage ="{0} phải nhập")]
		[DisplayName("Ngày tạo")]
		public DateTime Created { get; set; }

		[Column(TypeName ="ntext")]
		[DisplayName("Nội dung")]
		public string Content { get; set; }

	}

    // dotnet aspnet --codegeneration razerpage -m RAZORWEB.Models.Article -dc RAZORWEB.Models.MyBlogContext -outDir Pages/Blog -udl --referenceScriptLibraries
}

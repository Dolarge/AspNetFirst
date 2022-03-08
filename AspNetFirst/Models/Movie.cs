using System.ComponentModel.DataAnnotations;

namespace AspNetFirst.Models
{
    //ID 필드는 데이터베이스에서 기본 키 대신 필요
    //속성의 데이터 형식을 지정하는 [DataType] 특성
    
    //[DataType] 
    //사용자가 날짜 필드에 시간 정보를 입력할 필요가 없다
    //시간 정보 없이 날짜만 표시된다.
    
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime ReleaseData { get; set; }
        public string Genre { get; set; } = string.Empty ;
        public decimal Price { get; set; }

    }
}

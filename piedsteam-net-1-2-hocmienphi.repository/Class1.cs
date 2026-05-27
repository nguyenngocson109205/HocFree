namespace piedsteam_net_1_2_hocmienphi.repository
{
    public class Class1
    {
    }
    
    // CODE FIRST | DATABASE FIRST
    // ORM
    
    // thông thường để mà trên code có thể làm việc được với database 
        // thì mình cần phải ánh xja (mapping) từ các table lên code 
        // để dễ dàng thao tác với dữ liệu
        
    // Database First:
    // Mình làm việc với một database đã có sẵn, (Create database bằng sql)
    // vô tọa database nè, setup các filed, các mối quan hệ ràng buộc trong DB
    // Sau đó ở trên code sử dụng các Diver hoặc tạo thư viện ORM để
        // kết nới xuống database
    // ở trên code sẽ tọa các class tương úng với cáci table trng database 
    // thằng này sử dụng khi: databáse đã có sẵn và đang đươcj sử dụng
     // trong nhiều năm, được jion vào dự án main 
     
     // CODE First
     // Mình sẽ không setup database thủ công các câu lệnh query
        // create database, create contraint
        
    // minh sẽ design database bàng các class trên code, trên code setup như thê snoaf 
        // thì database sẽ đc tạo ra như thế đó 
        // mình sẽ setup trên code các filde, các relationship
        // sau đó mình ánh xạ các đoạn code đó để tọa ra các table trong database
    // vậy thì làm thế nào để ánh xja đưuocj code xuống các table trong databse
        // câu trả lời: ORM - Object Relation ship - Entity Framwork
        // nó sẽ là thằng trung gian đứng giữa nhiều thứ
            // nó sẽ đọc các class trên code, đọc các atttritubem đọc các cấu hình 
                // sau đó tạo ra các câu lệnh SQL để tạo ra các bảng.
            // nó cũng là thằng kết hợp với LINQ
                // khi sử udnjg các hà Where..., translate sang SQL
                // .WHERE() => select * from table where ...
    // thầng này được sử dụng khi:
        // mình mới bắt đầu dự á, chưa có database nào cả
        // thiết kế bằng code thì nó sẽ dễn  dàng maintain (dễ nhìn
            // dễ sử đổi ) hơn so với các câu lệnh SQL 
    // nếu không biết về LINQ + EF thì mất mịe 95% sức mạnh 
} 


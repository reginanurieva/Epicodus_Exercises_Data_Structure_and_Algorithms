$(document).ready(function() {


    $("form#quiz").submit(function() {
     event.preventDefault();
      var add = function(q1, q2, q3, q4, q5, q6) {
        return q1 + q2 + q3 + q4 + q5 + q6;
};

      var q1 = parseInt($("input:radio[name='xy1']:checked").val());
      var q2 = parseInt($("input:radio[name='xy2']:checked").val());
      var q3 = parseInt($("input:radio[name='xy3']:checked").val());
      var q4 = parseInt($("input:radio[name='xy4']:checked").val());
      var q5 = parseInt($("input:radio[name='xy5']:checked").val());
      var q6 = parseInt($("input:radio[name='xy6']:checked").val());
      var result = parseInt(add(q1, q2, q3, q4, q5, q6).toString());

      if (result === 3) {
      $("#output").text("PHP is by far the most popular backend language today, with 80 percent of websites utilizing it 'server-side'. It is perhaps best known for it's use in content management systems like Wordpress, Drupal, and Joomla. But the versatility of the language and the frameworks it powers make employment options numerous and diverse. If you're keen to work for a fast paced agency that builds websites for lots of clients, or maintain the security and stability of a huge complex of government websites, or if you like the idea of building out small sites for brands, businesses, and organizations - In any of these cases, PHP would be a great way to go.");
      }
      else if (result === 6){
      $("#output").text("C# is most popular among bigger established businesses, often for building internal software. Because it's been around for a long time and has the backing of Microsoft, it is one of the most in-demand languages in the job market. C# has also been going through a bit of a rebirth lately, with Microsoft open sourcing the language and surrounding platform, porting it to run on Mac and Linux, and incorporating many of the best features of other languages. If you like the idea of working for a larger company on business software, C# is a great choice!");
      }
      else if (result <= 9){
      $("#output").text("Ruby is a favorite language of developers building interactive web applications. If an app involves users creating accounts, entering information, and interacting with dynamic content, there's a good chance it is built with Ruby. Ruby became popular because the Rails framework, which is written with Ruby, simplified many of the common tasks associated with building web applications. It's most popular with startups and smaller companies who are looking to build their product quickly!");
      }
      else {
      alert("Hmmm....! This is different! But do't worry! The most important thing is to get the basic principles of coding down, practice a lot, and be ready to change to another language when your job inevitably does.")
      }






});});

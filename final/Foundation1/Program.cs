using System;

class Program
{
    static void Main(string[] args)
    {
        //video 1
        Video video1 = new Video();
        video1._title = "c# Tutorial";
        video1._authorName = "Tech Plus";
        video1._videoLength = 1801;

        Comment csharpComment1 = new Comment();
        csharpComment1._commentAuthor ="Flex";
        csharpComment1._comment = "Good Video Thanks.";
        video1._commentList.Add(csharpComment1);

        Comment csharpComment2 = new Comment();
        csharpComment2._commentAuthor ="Rsalazar";
        csharpComment2._comment = "I Learn a lot with this tutorial.";
        video1._commentList.Add(csharpComment2);

        Comment csharpComment3 = new Comment();
        csharpComment3._commentAuthor ="Nando";
        csharpComment3._comment = "Make more videos like this thanks.";
        video1._commentList.Add(csharpComment3);

        video1.DisplayVideoInformation();

        
        //video 2
        Video video2 = new Video();
        video2._title = "Python Course";
        video2._authorName = "Program With me";
        video2._videoLength = 2103;

        Comment pythonComment1 = new Comment();
        pythonComment1._commentAuthor ="Ricky";
        pythonComment1._comment = "I like your videos.";
        video2._commentList.Add(pythonComment1);

        Comment pythonComment2 = new Comment();
        pythonComment2._commentAuthor ="Benjamin Salazar";
        pythonComment2._comment = "Thanks for the video, it is usefull.";
        video2._commentList.Add(pythonComment2);

        Comment pythonComment3 = new Comment();
        pythonComment3._commentAuthor ="John Caceres";
        pythonComment3._comment = "how much earns a programer??";
        video2._commentList.Add(pythonComment3);

        video2.DisplayVideoInformation();

        //video 3
        Video video3 = new Video();
        video3._title = "Learning Java";
        video3._authorName = "Easy Cod";
        video3._videoLength = 2356;

        Comment javacomment1 = new Comment();
        javacomment1._commentAuthor ="John Caceres";
        javacomment1._comment = "Java is best programing lenguage.";
        video3._commentList.Add(javacomment1);

        Comment Javacomment2 = new Comment();
        Javacomment2._commentAuthor ="Benjamin";
        Javacomment2._comment = "Python is better.";
        video3._commentList.Add(Javacomment2);

        Comment Javacomment3 = new Comment();
        Javacomment3._commentAuthor ="John Caceres";
        Javacomment3._comment = "Benjamin, Java is better than Python.";
        video3._commentList.Add(Javacomment3);

        Comment Javacomment4 = new Comment();
        Javacomment4._commentAuthor ="Benjamin";
        Javacomment4._comment = "That is not True!";
        video3._commentList.Add(Javacomment4);

        video3.DisplayVideoInformation();
        


        


    }
}
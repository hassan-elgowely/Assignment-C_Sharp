using AssignmentOOP02.Question_01;
using AssignmentOOP02.Question_02;
using AssignmentOOP02.Question_03;
using System;
using System.Data;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOOP02
{
    internal class Program
    {
        #region Method Q1 Part 02
        public static void Print(IShape shape)
        {
            shape.DisplayShapeInfo();
        }
        #endregion

        #region Method Q3 Part 02
        public static void Notification(INotificationService notification , string recipient , string mess)
        {
            notification.SendNotification(recipient,mess);
        }
        #endregion


        static void Main(string[] args)
        {

            #region Part 01

            #region Q1
            // What is the primary purpose of an interface in C#? 

            // b) To define a blueprint for a class 
            #endregion

            #region Q2
            // Which of the following is NOT a valid access modifier for interface members in C#? 

            // a) private 
            #endregion

            #region Q3
            // Can an interface contain fields in C#? 

            // c) Only if they are static 
            #endregion

            #region Q4
            // In C#, can an interface inherit from another interface? 

            // b) Yes, interfaces can inherit from multiple interfaces 
            #endregion

            #region Q5
            // Which keyword is used to implement an interface in a class in C#? 

            // d) implements 
            #endregion

            #region Q6
            // Can an interface contain static methods in C#? 

            // a) Yes 
            #endregion

            #region Q7
            // In C#, can an interface have explicit access modifiers for its members? 

            // a) Yes, for all members 
            #endregion

            #region Q8
            // What is the purpose of an explicit interface implementation in C#?

            // b) To provide a clear separation between interface and class members
            #endregion

            #region Q9
            // In C#, can an interface have a constructor? 

            // d) Only if the constructor is static 
            #endregion

            #region Q10
            // How can a C# class implement multiple interfaces? 

            // c) By separating interface names with commas 
            #endregion

            #endregion


            #region Part 02

            #region Q1
            /// Define an interface named IShape with a property Area and a method
            /// DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from
            /// IShape.Implement these interfaces in classes Circle and Rectangle. Test your
            /// implementation by creating instances of both classes and displaying their shape information. 

            //Rectangle rectangle = new Rectangle() {Width = 5 , Length = 3 };
            //Circle circle = new Circle() {Diameter = 4 };
            //Print(rectangle);
            //Print(circle);
            #endregion

            #region Q2
            /// In this example, we start by defining the IAuthenticationService interface with
            /// two methods: AuthenticateUser and AuthorizeUser.The
            /// BasicAuthenticationService class implements this interface and provides the
            /// specific implementation for these methods.
            /// In the BasicAuthenticationService class, the AuthenticateUser method compares
            /// the provided username and password with the stored credentials.It returns true 
            /// if the user is authenticated and false otherwise.The AuthorizeUser method
            /// checks if the user with the given username has the specified role.It returns true if 
            /// the user is authorized and false otherwise.
            /// In the Main method, we create an instance of the BasicAuthenticationService
            /// class and assign it to the authService variable of type IAuthenticationService.We
            /// then call the AuthenticateUser and AuthorizeUser methods using this interface
            /// reference. 
            /// This implementation allows you to switch the authentication service
            /// implementation easily by creating a new class that implements the
            /// IAuthenticationService interface and providing the desired logic for 
            /// authentication and authorization.

            //IAuthenticationService authenticationService = new AuthenticationService() { UserName = "Ahmed" , Password ="102030" , Role = "Admin" };

            //Console.WriteLine(authenticationService.AuthenticateUser());
            //Console.WriteLine(authenticationService.AuthorizeUser());

            //IAuthenticationService authenticationService02 = new AuthenticationService() { UserName = "mohamed", Password = "123", Role = "Admin" };

            //Console.WriteLine(authenticationService02.AuthenticateUser());
            //Console.WriteLine(authenticationService02.AuthorizeUser());

            #endregion

            #region Q3
            /// we define the INotificationService interface with a method SendNotification that
            /// takes a recipient and a message as parameters.
            /// We then create three classes: EmailNotificationService, SmsNotificationService, 
            /// and PushNotificationService, which implement the INotificationService interface. 
            /// In each implementation, we provide the logic to send notifications through the
            /// respective communication channel: 
            /// The EmailNotificationService class simulates sending an email by outputting a
            /// message to the console.
            /// The SmsNotificationService class simulates sending an SMS by outputting a
            /// message to the console.
            /// The PushNotificationService class simulates sending a push notification by
            /// outputting a message to the console.
            /// In the Main method, we create instances of each notification service class and call
            /// the SendNotification method with sample recipient and message values.
            /// This implementation allows you to easily switch between different notification
            /// channels by creating new classes that implement the INotificationService
            /// interface and provide the specific logic for each channel.

            //Notification(new EmailNotificationService() , "ahmed@gmail.com", "Hello World");
            //Notification(new SmsNotificationService() , "01234567899", "Hello World");
            //Notification(new EmailNotificationService() , "user4050", "Cash");
            #endregion

            #endregion


        }
    }
}

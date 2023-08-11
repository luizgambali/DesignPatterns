/*
    The Bridge Pattern decouples an abstraction from its implementation so that the two can vary independently.

    In this example, we have a Message class that has a MessageSender interface. The MessageSender interface has a SendMessage method. 
    The Message class has a MessageSender property. The Message class has two subclasses: SystemMessage and UserMessage. The SystemMessage 
    class has a Send method that calls the SendMessage method of the MessageSender interface. The UserMessage class has a Send method that 
    calls the SendMessage method of the MessageSender interface. The MessageSender interface has three implementations: EmailSender, QueueSender, 
    and WebServiceSender. The EmailSender class has a SendMessage method that sends an email. The QueueSender class has a SendMessage method 
    that sends a message to a Message Queue. The WebServiceSender class has a SendMessage method that sends a message to a web service.


    Reference: adapted from https://medium.com/xp-inc/desing-patterns-parte-9-bridge-5ca127f72de
*/


IMessageSender email = new EmailSender();
IMessageSender queue = new QueueSender();
IMessageSender web = new WebServiceSender();

Message message = new SystemMessage();
message.Subject = "Message Subject";
message.Body = "Body Message ";
 
message.MessageSender = email;
message.Send();

message.MessageSender = queue;
message.Send();

message.MessageSender = web;
message.Send();

UserMessage usermsg = new UserMessage();
usermsg.Subject = "Message Subject";
usermsg.Body = "Body Message ";
usermsg.UserComments = "Comment here...";

usermsg.MessageSender = email;
usermsg.Send();
using SistemaNotificacoes;

Console.WriteLine("Sistema de notificação: "); // arrumar depois
Notificacao notificacao1 = new Email();
notificacao1.Enviar();

Notificacao notificacao2 = new Sms();
notificacao2.Enviar();

Notificacao notificacao3 = new PushNotification();
notificacao3.Enviar();



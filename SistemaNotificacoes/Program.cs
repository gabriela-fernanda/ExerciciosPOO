using SistemaNotificacoes;

Notificacao[] notificacoes = new Notificacao[3];

notificacoes[0] = new Email();
notificacoes[1] = new Sms();
notificacoes[2] = new PushNotification();

foreach (var notificacao in notificacoes)
{
    notificacao.Enviar("Olá! Esta é uma notificação importante.");
}


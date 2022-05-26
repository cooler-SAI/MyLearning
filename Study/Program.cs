using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;

namespace Study
{

    class Program
    {
        #region BotKey
        static ITelegramBotClient bot = new TelegramBotClient("TOKEN");
        #endregion

        #region HandleUpdateAsync
        /// <summary>
        /// Async in real time, here Bot live and talk
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="update"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        static readonly ITelegramBotClient? botClient;
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // We work here in chat with bot:
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == UpdateType.Message && update?.Message?.Document != null)
            {
                await BotSaveFiles(botClient, update.Message);

            }
            if (update!.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;                
                if (message!.Text!.ToLower() == "/hi" )
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "How are you today ? " +
                    "\n/good ? or /bad ? ");
                    return;
                }
                if (message.Text.ToLower() == "/hello")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "You too) How are you today ? " +
                    "\n/good ? or /bad ? ", replyToMessageId: message.MessageId);
                    return;
                }
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Hello, human! Good day to you!" +
                        "\nSay /hello or /hi ");
                    return;
                }        
                if (message.Text.ToLower() == "/good")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Nice to know that." +
                        "\nI wanna work with you, if you wish." +
                    "\nPlease type one of this commands to chat:" +
                    "\nSave files: /file  ", replyToMessageId: message.MessageId);
                    return;
                }
                if (message.Text.ToLower() == "/bad")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "It's sad. I can tell you drink a cup of tea" +
                        "\nwith delicies Cake" +
                    "\nGood idea, isn't it? ))" +
                    "\nDon't worry. All be good enough ", replyToMessageId: message.MessageId);
                    return;
                }
                if (message.Text.ToLower() == "/file")
                {
                    GetFilesFromBot(message);
                }
                if (message.Text.ToLower() == "CyberGirl")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Yeah! that's my name ^_^ ", replyToMessageId: message.MessageId);
                    return;
                }
            }
        }
        #endregion

        #region HandleErrorAsync
        /// <summary>
        /// If Async got Error
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="exception"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
            return Task.CompletedTask;
        }
        #endregion
        /// <summary>
        /// Here Bot can save files from User!
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        static async Task BotSaveFiles(ITelegramBotClient botClient, Message message)
        {
            var UserfileId = message?.Document?.FileId;
            var path = message?.Document?.FileName;
            var file = await botClient.GetFileAsync(UserfileId!);
            var fileStream = new FileStream("_" + path, FileMode.Create);
            await botClient.DownloadFileAsync(file.FilePath!, fileStream);
            await botClient.SendTextMessageAsync(message!.Chat.Id, "I saved it to my NetFileStream." +
                "\nUse command /file for download and see all of them. ", replyToMessageId: message.MessageId);
            fileStream.Close();
            fileStream.Dispose();
        }
        /// <summary>
        /// Get files from Bot to PC
        /// </summary>
        /// <param name="message"></param>
        static async void GetFilesFromBot( Message message)
        {
            var path = message?.Document?.FileName;
            var info = new DirectoryInfo(@"D:\Downloads\Bot");
            try
            {
                FileInfo[] fileinfo = info.GetFiles();
                foreach (var item in fileinfo)
                {
                    var stream = new FileStream(item.FullName, FileMode.Open);
                    var file = new InputOnlineFile(stream, stream.Name);
                    await botClient!.SendDocumentAsync(message!.Chat.Id, file);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Directory can not be found! ");
            }

        }

        static void Main(string[] args)
        {
            // Here Bot can live message
            Console.WriteLine("Bot is running... " + bot.GetMeAsync().Result.FirstName);

            var botkey = new CancellationTokenSource();
            var cancellationToken = botkey.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types from Telegram in real time
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}

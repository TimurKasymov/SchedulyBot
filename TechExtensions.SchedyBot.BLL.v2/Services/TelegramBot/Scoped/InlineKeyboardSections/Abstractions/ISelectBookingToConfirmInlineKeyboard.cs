﻿using TechExtensions.SchedyBot.DLL.Entities;
using Telegram.Bot.Types;

namespace TechExtensions.SchedyBot.BLL.v2.Services.TelegramBot.Scoped.InlineKeyboardSections.Abstractions
{
    public interface ISelectBookingToConfirmInlineKeyboard
    {
        public delegate Task HandleMethod(CurrentDialog currentDialog, CallbackQuery callbackQuery);
        public HandleMethod handleKeyboardExit { get; set; }
        /// <summary>
        /// Запускает InlineKeyBoardSection
        /// </summary>
        /// <param name="currentDialog"></param>
        /// <returns></returns>
        public Task Launch(CurrentDialog currentDialog);

        /// <summary>
        /// Обновляет InlineKeyBoardSection
        /// </summary>
        /// <param name="currentDialog"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        public Task<CurrentDialog> Handle(CurrentDialog currentDialog, Update update);
    }
}

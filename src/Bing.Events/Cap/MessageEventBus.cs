﻿using System;
using System.Threading.Tasks;
using Bing.Datas.Transactions;
using Bing.Events.Messages;
using DotNetCore.CAP;

namespace Bing.Events.Cap
{
    /// <summary>
    /// Cap消息事件总线
    /// </summary>
    public class MessageEventBus:IMessageEventBus
    {
        /// <summary>
        /// 事件发布器
        /// </summary>
        public ICapPublisher Publisher { get; set; }

        /// <summary>
        /// 事务操作管理器
        /// </summary>
        public ITransactionActionManager TransactionActionManager { get; set; }

        /// <summary>
        /// 初始化一个<see cref="MessageEventBus"/>类型的实例
        /// </summary>
        /// <param name="publisher">事件发布器</param>
        /// <param name="transactionActionManager">事务操作管理器</param>
        public MessageEventBus(ICapPublisher publisher, ITransactionActionManager transactionActionManager)
        {
            Publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
            TransactionActionManager = transactionActionManager ?? throw new ArgumentNullException(nameof(transactionActionManager));
        }

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <typeparam name="TEvent">事件类型</typeparam>
        /// <param name="event">事件</param>
        /// <returns></returns>
        public Task PublishAsync<TEvent>(TEvent @event) where TEvent : IMessageEvent
        {
            return PublishAsync(@event.Name, @event.Data, @event.Callback);
        }

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="name">消息名称</param>
        /// <param name="data">事件数据</param>
        /// <param name="callback">回调名称</param>
        /// <returns></returns>
        public Task PublishAsync(string name, object data, string callback)
        {
            TransactionActionManager.Register(async transaction =>
            {
                Publisher.Transaction.DbTransaction = transaction;
                Publisher.Transaction.AutoCommit = false;
                await Publisher.PublishAsync(name, data, callback);
            });

            return Task.CompletedTask;
        }
    }
}

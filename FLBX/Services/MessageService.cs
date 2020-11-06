using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace FLBX
{
    public class MessageService
    {
        IConfiguration _configuration;
        IHttpClientFactory _clientFactory;

        public FLMessageSet MessageSet { get; set; }

        public MessageService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._clientFactory = clientFactory;
        }

        public FLMessageSet CreateMessageSet(string messageType, 
                                                QueryMessage? queryMesage, 
                                                RuleMessage? ruleMessage, 
                                                EquipmentMessage? equipmentMessage)
        {
            this.MessageSet = new FLMessageSet();

            MessageHeader header = new MessageHeader();
            header.TargetSystem = @"MOM";
            header.SourceSystem = @"FLBX";
            header.MessageType = messageType;
            header.SiteId = "A_10";
            //header.UserId = "";
            //header.SecretToken = "";
            //header.TargetUrl = "";
            //header.Tid = "";
            //header.TimeStamp = "";
            //header.SourceIpAddress = "";
            //header.Language = "";
            //header.Encoding = "";
            //header.CommunicatoinType = "";

            this.MessageSet.FlMessageHeader = header;
            this.MessageSet.QueryMessage = queryMesage;
            this.MessageSet.RuleMessage = ruleMessage;
            this.MessageSet.EquipmentMessage = equipmentMessage;

            return this.MessageSet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceModuleName">ex."Product", "Equipment", "Quality"</param>
        /// <param name="controllerPath">ex. "/api/mens"</param>
        /// <returns></returns>
        public async Task<ReplyMessage> SendMessageAsync(string serviceModuleName, string controllerPath, FLMessageSet messageSet)
        {
            string targetUrl = GetTargetUrl(serviceModuleName);
            this.MessageSet.FlMessageHeader.TargetUrl = targetUrl;

            HttpResponseMessage replyMessage = await this._clientFactory.CreateClient().PostAsJsonAsync<FLMessageSet>(targetUrl + controllerPath, messageSet);
            
            return await replyMessage.Content.ReadFromJsonAsync<ReplyMessage>();
        }

        private string GetTargetUrl(string serviceModuleName)
        {
            return _configuration.GetSection(@"Hosts").GetSection(serviceModuleName).Value;
        }
    }
}

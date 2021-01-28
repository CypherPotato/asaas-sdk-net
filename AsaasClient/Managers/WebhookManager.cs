﻿using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Webhook;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class WebhookManager : BaseManager
    {
        private const string WEBHOOK_URL = "/webhook";

        public WebhookManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Webhook>> CreateOrUpdatePaymentWebhook(WebhookRequest requestObj)
        {
            var responseObject = await PostAsync<Webhook>(WEBHOOK_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<Webhook>> FindPaymentWebhook()
        {
            var responseObject = await GetAsync<Webhook>(WEBHOOK_URL, null);

            return responseObject;
        }

        public async Task<ResponseObject<Webhook>> CreateOrUpdateInvoiceWebhook(WebhookRequest requestObj)
        {
            var url = $"{WEBHOOK_URL}/invoice";
            var responseObject = await PostAsync<Webhook>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<Webhook>> FindInvoiceWebhook()
        {
            var url = $"{WEBHOOK_URL}/invoice";
            var responseObject = await GetAsync<Webhook>(url);

            return responseObject;
        }
    }
}
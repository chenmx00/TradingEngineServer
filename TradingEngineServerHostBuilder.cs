using Microsoft.Extensions.Hosting;
using Polly;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {  
        public static  IHost BuildTradingEngineServer() => Host.CreateDefaultBuilder().ConfigureServices((Context, services)) => {
        }).Build();
    }
}

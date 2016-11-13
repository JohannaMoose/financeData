using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceData
{
    public class Stock
    {
        public string symbol { get; set; }
        public string Ask { get; set; }
        public string AverageDailyVolume { get; set; }
        public string Bid { get; set; }
        public object AskRealtime { get; set; }
        public object BidRealtime { get; set; }
        public string BookValue { get; set; }
        public string Change_PercentChange { get; set; }
        public string Change { get; set; }
        public object Commission { get; set; }
        public string Currency { get; set; }
        public object ChangeRealtime { get; set; }
        public object AfterHoursChangeRealtime { get; set; }
        public object DividendShare { get; set; }
        public string LastTradeDate { get; set; }
        public object TradeDate { get; set; }
        public object EarningsShare { get; set; }
        public object ErrorIndicationreturnedforsymbolchangedinvalid { get; set; }
        public object EPSEstimateCurrentYear { get; set; }
        public object EPSEstimateNextYear { get; set; }
        public string EPSEstimateNextQuarter { get; set; }
        public string DaysLow { get; set; }
        public string DaysHigh { get; set; }
        public string YearLow { get; set; }
        public string YearHigh { get; set; }
        public object HoldingsGainPercent { get; set; }
        public object AnnualizedGain { get; set; }
        public object HoldingsGain { get; set; }
        public object HoldingsGainPercentRealtime { get; set; }
        public object HoldingsGainRealtime { get; set; }
        public object MoreInfo { get; set; }
        public object OrderBookRealtime { get; set; }
        public object MarketCapitalization { get; set; }
        public object MarketCapRealtime { get; set; }
        public string EBITDA { get; set; }
        public string ChangeFromYearLow { get; set; }
        public string PercentChangeFromYearLow { get; set; }
        public object LastTradeRealtimeWithTime { get; set; }
        public object ChangePercentRealtime { get; set; }
        public string ChangeFromYearHigh { get; set; }
        public string PercebtChangeFromYearHigh { get; set; }
        public string LastTradeWithTime { get; set; }
        public string LastTradePriceOnly { get; set; }
        public object HighLimit { get; set; }
        public object LowLimit { get; set; }
        public string DaysRange { get; set; }
        public object DaysRangeRealtime { get; set; }
        public string FiftydayMovingAverage { get; set; }
        public string TwoHundreddayMovingAverage { get; set; }
        public string ChangeFromTwoHundreddayMovingAverage { get; set; }
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }
        public string ChangeFromFiftydayMovingAverage { get; set; }
        public string PercentChangeFromFiftydayMovingAverage { get; set; }
        public string Name { get; set; }
        public object Notes { get; set; }
        public string Open { get; set; }
        public string PreviousClose { get; set; }
        public object PricePaid { get; set; }
        public string ChangeinPercent { get; set; }
        public object PriceSales { get; set; }
        public object PriceBook { get; set; }
        public string ExDividendDate { get; set; }
        public object PERatio { get; set; }
        public object DividendPayDate { get; set; }
        public object PERatioRealtime { get; set; }
        public string PEGRatio { get; set; }
        public object PriceEPSEstimateCurrentYear { get; set; }
        public object PriceEPSEstimateNextYear { get; set; }
        public string Symbol { get; set; }
        public object SharesOwned { get; set; }
        public string ShortRatio { get; set; }
        public string LastTradeTime { get; set; }
        public object TickerTrend { get; set; }
        public object OneyrTargetPrice { get; set; }
        public string Volume { get; set; }
        public object HoldingsValue { get; set; }
        public object HoldingsValueRealtime { get; set; }
        public string YearRange { get; set; }
        public object DaysValueChange { get; set; }
        public object DaysValueChangeRealtime { get; set; }
        public string StockExchange { get; set; }
        public object DividendYield { get; set; }
        public string PercentChange { get; set; }
    }
}

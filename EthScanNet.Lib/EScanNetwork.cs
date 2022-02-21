// ReSharper disable IdentifierTypo

using System;

namespace EthScanNet.Lib
{
    public class EScanNetwork
    {
        public static readonly EScanNetwork MainNet = new("https://api.etherscan.io/api", false, false);
        [Obsolete("Will be replaced with MainNet and deprecated")]
        public static readonly EScanNetwork EScanMainNet = new("https://api.etherscan.io/api", false, false);
        public static readonly EScanNetwork RopstenNet = new("https://api-ropsten.etherscan.io/api", false, false);
        public static readonly EScanNetwork KovanNet = new("https://api-kovan.etherscan.io/api", false, false);
        public static readonly EScanNetwork RinkebyNet = new("https://api-rinkeby.etherscan.io/api", false, false);
        public static readonly EScanNetwork GoerliNet = new("https://api-goerli.etherscan.io/api", false, false);
        public static readonly EScanNetwork BscTestNet = new("https://api-testnet.bscscan.com/api", true, false);
        public static readonly EScanNetwork BscMainNet = new("https://api.bscscan.com/api", true, false);
        public static readonly EScanNetwork PolygonTestNet = new("https://api-testnet.polygonscan.com/api", false, true);
        public static readonly EScanNetwork PolygonMainNet = new("https://api.polygonscan.com/api", false, true);

        public bool IsBsc { get; }
        public bool IsPolygon { get; }

        private readonly string _networkString;
        
        private EScanNetwork(string networkString, bool isBsc, bool isPolygon)
        {
            this._networkString = networkString;
            this.IsBsc = isBsc;
            this.IsPolygon = isPolygon;
        }

        public override string ToString()
        {
            return this._networkString;
        }

        public static implicit operator string(EScanNetwork network)
        {
            return network._networkString;
        }
    }
}
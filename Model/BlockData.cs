using System;
using System.Collections.Generic;

namespace BlockApi.Model
{
    public class BlockData
    {
        public int status {get;set;}
        public string message {get;set;}
        public List<BlockDataItem> result {get; set;}
    }

    public class BlockDataItem
    {
        public string address {get;set;}
        public List<string> topics {get;set;}
        public string data {get;set;}
        public string blockNumber {get;set;}        
        public string timeStamp {get;set;}   
        public string gasPrice {get;set;}   
        public string gasUsed {get;set;}   
        public string logIndex {get;set;}   
        public string transactionHash {get;set;}   
        public string transactionIndex {get;set;}
    }
}
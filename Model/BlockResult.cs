using System;
using System.Collections.Generic;

namespace BlockApi.Model
{
    public class BlockResult
    {          
        public string txHash {get;set;}        
        public decimal blockNumber {get;set;} 
        public DateTime timestamp {get;set;}
        public decimal gasPrice {get;set;}
        public decimal gasUsed {get;set;}
    }    
}
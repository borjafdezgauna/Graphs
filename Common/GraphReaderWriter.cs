using System;
using System.IO;

namespace Common
{
    public class GraphReaderWriter
    {
        private string EncodeString(string str)
        {
            //TODO #20: Replace all separators and special characters used in your file by some improbable tag (i.e, "[NEW_LINE]")
            
            return str;
            
        }
        private string DecodeString(string str)
        {
            //TODO #21: Replace your special tags (i.e, "NEW_LINE") by the original separator before encoding it
            
            return str;
            
        }
        public bool Write<TKey, TWeight>(UnDirectedGraph<TKey, TWeight> graph, string filename,
            Func<TKey, string> keyToString, Func<TWeight, string> weightToString) where TKey : IComparable<TKey>
        {
            try
            {
                TextWriter writer = File.CreateText(filename);

                //TODO #22: Write first all the nodes as strings (one line each), then one empty line, and then each of the edges with the format "A->1->B" (one line each)
                

                writer.Close();

                return true;
            }
            catch (Exception ex){ return false; }
        }

        public bool Read<TKey, TWeight>(UnDirectedGraph<TKey, TWeight> graph, string filename,
            Func<string, TKey> stringToKey, Func<string, TWeight> weightToKey) where TKey : IComparable<TKey>
        {
            try
            {
                TextReader reader = File.OpenText(filename);

                //TODO #23: Read all the nodes first and, when you find an empty line, start reading edges
                //Edges will have the format "A->1->B", so you need to use line.Split("->") to receive the three different parts in an array
                
                reader.Close();

                return true;
            }
            catch (Exception ex){ return false; }
        }
    }
}

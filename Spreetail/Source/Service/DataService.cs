using System;
using PowerArgs;
using Spreetail.WorkSample.Source.Models;
using Spreetail.WorkSample.Source.Repository;
using System.Linq;

namespace Spreetail.WorkSample.Source.Service
{
    [ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
    public class DataService
    {
        private readonly IDataRepository _dataRepository;

        public DataService()
        {
            _dataRepository = new DataRepository();
        }

        [ArgActionMethod, ArgDescription("Add a member to a collection for a given key. Displays an error if the value already existed in the collection.")]
        public void Add(KeyValueArgs args)
        {
            var result = _dataRepository.Add(args.Key, args.Value);

            if (result)
                Console.WriteLine(MessageResources.ADDED);
            else
                Console.WriteLine(MessageResources.VALUE_ALREADY_EXIST);
        }

        [ArgActionMethod, ArgDescription("Removes all keys and all values from the dictionary.")]
        public void Clear()
        {
            _dataRepository.Clear();
            Console.WriteLine(MessageResources.CLEARED);
        }

        [ArgActionMethod, ArgDescription("Returns all keys in the dictionary and all of their values. Returns nothing if there are none. Order is not guaranteed.")]
        public void Items()
        {
            var result = _dataRepository.Items();

            if (result.Count() > 0)
            {
                int i = 0;
                foreach (var p in result)
                {
                    Console.WriteLine($"{++i}) {p.Key} : {p.Value}");
                }
            }
            else
            {
                Console.WriteLine(MessageResources.EMPTY_SET);
            }
        }

        [ArgActionMethod, ArgDescription("Returns all the keys in the dictionary. Order is not guaranteed.")]
        public void Keys()
        {
            var result = _dataRepository.Keys();

            if (result.Count() > 0)
            {
                int i = 0;
                foreach (string key in result)
                {
                    Console.WriteLine($"{++i}) {key}");
                }
            }
            else
            {
                Console.WriteLine(MessageResources.EMPTY_SET);
            }
        }

        [ArgActionMethod, ArgDescription("Returns the collection of strings for the given key. Return order is not guaranteed. Returns an error if the key does not exists.")]
        public void Members(OneArgs args)
        {
            var result = _dataRepository.Members(args.Key);

            if (result != null)
            {
                int i = 0;
                foreach (string value in result)
                {
                    Console.WriteLine($"{++i}) {value}");
                }
            }
            else
            {
                Console.WriteLine(MessageResources.KEY_NOT_EXIST);
            }

            
        }

        [ArgActionMethod, ArgDescription("Returns all the values in the dictionary. Returns nothing if there are none. Order is not guaranteed.")]
        public void AllMembers()
        {
            var result = _dataRepository.Members();

            if (result.Count() > 0)
            {
                int i = 0;
                foreach (string value in result)
                {
                    Console.WriteLine($"{++i}) {value}");
                }
            }
            else
            {
                Console.WriteLine(MessageResources.EMPTY_SET);
            }
        }

        [ArgActionMethod, ArgDescription("Returns whether a key exists or not.")]
        public void KeyExists(OneArgs args)
        {
            var result = _dataRepository.KeyExists(args.Key);

            if (result)
                Console.WriteLine(MessageResources.TRUE);
            else
                Console.WriteLine(MessageResources.FALSE);
        }

        [ArgActionMethod, ArgDescription("Returns whether a value exists within a key. Returns false if the key does not exist.")]
        public void ValueExists(KeyValueArgs args)
        {
            var result = _dataRepository.ValueExists(args.Key, args.Value);

            if (result)
                Console.WriteLine(MessageResources.TRUE);
            else
                Console.WriteLine(MessageResources.FALSE);
        }

        [ArgActionMethod, ArgDescription("Removes a value from a key. If the last value is removed from the key, they key is removed from the dictionary. If the key or value does not exist, displays an error.")]
        public void Remove(KeyValueArgs args)
        {
            var result = _dataRepository.KeyExists(args.Key);

            if (result)
            {
               var result1 = _dataRepository.Remove(args.Key, args.Value);

                if (result1)
                    Console.WriteLine(MessageResources.REMOVED);
                else
                    Console.WriteLine(MessageResources.VALUE_NOT_EXIST);
            }
            else
            {
                Console.WriteLine(MessageResources.FALSE);
            }
        }

        [ArgActionMethod, ArgDescription("Removes all value for a key and removes the key from the dictionary. Returns an error if the key does not exist.")]
        public void RemoveAll(OneArgs args)
        {
            var result = _dataRepository.Remove(args.Key);

            if (result)
            {
                Console.WriteLine(MessageResources.REMOVED);
            }
            else
            {
                Console.WriteLine(MessageResources.KEY_NOT_EXIST);
            }
        }

        [ArgActionMethod, ArgDescription("Clean Console")]
        public void Clean()
        {
            Console.Clear();
        }

        [ArgActionMethod, ArgDescription("Clean Console")]
        public void Exit()
        {
            Console.WriteLine($"Thank you for using this program. Press Any Key");
            Console.ReadLine();
            Environment.Exit(0);
        }


    }
}

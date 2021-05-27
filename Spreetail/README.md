# Back End Work Sample – Multi Value Dictionary
A C# .NET Core Class Library containing tools for parsing the command line arguments that stores a key/multi-value pairs in memory. 
Key and Value pairs are strings and case sensitive.

## Why?
I needed an interactive command line application which parses the command line arguments based on the available commands and 
stores/manage key/multi-value pairs in memory.

# Requirements
- .Net Core 3.1 or higher.

## Download / Clone

Clone the repo using Git:

`git clone https://github.com/battaluri/MultiValueDictionaryWorkSample`

## Build and run
```
Navigate to the root folder downloaded/cloned and run below commands.

dotnet build
dotnet run
```

## Install .NET on Windows, Linux, and macOS
`https://docs.microsoft.com/en-us/dotnet/core/install/`

# Documentation
Supports the following commands. (All commands are case insensitive)

```
keys, members, add, remove, removeall, clear, keyexists, valueexists, allmembers, items, clean, exit, help, version
```

To get command usage for all available commands in console use help command

```
help 
Example: help

  keys           Returns all the keys in the dictionary. Order is not guaranteed.
                 usage: keys
  members        Returns the collection of strings for the given key. Return order is not guaranteed. Returns an error
                 if the key does not exists.
                 usage: members key
  add            Add a member to a collection for a given key. Displays an error if the value already existed in the
                 collection.
                 usage: add key value
  remove         Removes a value from a key. If the last value is removed from the key, they key is removed from the
                 dictionary. If the key or value does not exist, displays an error.
                 usage: remove key value
  removeall      Removes all value for a key and removes the key from the dictionary. Returns an error if the key does
                 not exist.
                 usage: removeall key
  clear          Removes all keys and all values from the dictionary.
                 usage: clear
  keyexists      Returns whether a key exists or not.
                 usage: keyexists key
  valueexists    Returns whether a value exists within a key. Returns false if the key does not exist.
                 usage: valueexists key value
  allmembers     Returns all the values in the dictionary. Returns nothing if there are none. Order is not guaranteed.
                 usage: allmembers
  items          Returns all keys in the dictionary and all of their values. Returns nothing if there are none. Order is
                 not guaranteed.
                 usage: items
  clean          Clean the console
                 usage: clean
  exit           Exit the program
                 usage: exit
  help           Display more information on a specific command.
                 usage: help
  version        Display version information.
                 usage: version
```

[All Commands with usage and samples](./Documentation/DetailedCommands.md)

### Is the key and value stored in the dictionary case sensitive?
Yes the key and value stored are case sensitive.

## Author
- [Bharat Chand Attaluri] - Senior Architect & Full-stack Engineer;

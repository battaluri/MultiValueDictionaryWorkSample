# All Commands with usage and samples

Supports the following commands

### help
Gives Information about all available operations that can be performed.
Example:
```
> help
```

### keys
Returns all the keys in the dictionary. Order is not guaranteed. 
Example:
```
> add foo bar
) Added
> add baz bang
) Added 
> keys 
1) foo 
2) baz
```

### members
Returns the collection of strings for the given key. Return order is not guaranteed. Returns an error if the key does not exists. 
Example:
```
> add foo bar
> add foo baz
> members foo
1) bar 
2) baz
 > members bad
 ) ERROR, key does not exist.
```

### add
Add a member to a collection for a given key. Displays an error if the value already existed in the collection.
Example:
```
> add foo bar
) Added
> add foo baz
) Added
> add foo bar
) ERROR, value already exists
```

### remove
Removes a value from a key. If the last value is removed from the key, they key is removed from the dictionary. If the key or value does not exist, displays an error. 
Example:
```
> add foo bar
) Added
> add foo baz
) Added
> remove foo bar
) Removed
> remove foo bar
) ERROR, value does not exist
> keys 
1) foo
> remove foo baz
) Removed
> keys
) empty set
> remove boom
) ERROR, key does not exist
```

### removeall
Removes all value for a key and removes the key from the dictionary. Returns an error if the key does not exist. 
Example:
```
> add foo bar
) Added
> add foo baz
) Added 
> keys 
1) foo
> removeall foo
) Removed
> keys
) empty set
removeall foo
) ERROR, key does not exist
```

### clear
Removes all keys and all values from the dictionary. 
Example:
```
> add foo bar
) Added
> add bang zip
) Added 
> keys 
1) foo 
2) bang
> clear
) Cleared
> keys
) empty set
> clear
) Cleared
> keys
) empty set
```

### keyexists
Returns whether a key exists or not. 
Example:
```
> keyexists foo
) false
> add foo bar
) Added
> keyexists foo
) true
```

### valueexists
Returns whether a value exists within a key. Returns false if the key does not exist. 
Example:
```
> valueexists foo bar
) false
> add foo bar
) Added
> valueexists foo bar
) true
> valueexists foo baz
) false
```

### allmembers
Returns all the values in the dictionary. Returns nothing if there are none. Order is not guaranteed. 
Example:
```
> allmembers
) empty set
> add foo bar
) Added
> add foo baz
) Added
> allmembers
1) bar
2) baz
> add bang bar
) Added
> add bang baz
> allmembers
1) bar 
2) baz 
3) bar 
4) baz
```

### items
Returns all keys in the dictionary and all of their values. Returns nothing if there are none. Order is not guaranteed. 
Example:
```
> items
) Added
> ITEMS
) Added
> ADD bang baz
> ITEMS
> add bang baz
> ALLMEMBERS
) empty set
> add foo bar
> add foo baz
) Added
1) foo: bar
2) foo: baz
> add bang bar
1) foo: bar
2) foo: baz
3) bang: bar
4) bang: baz
```
### clean
Clean the console. 
Example:
```
> clean
```
### exit
Exit the program. 
Example:
```
> exit
```
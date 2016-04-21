## Recently Used List Kata

Develop a recently-used-list class to hold strings
uniquely in Last-In-First-Out order.

* The most recently added item is first, the least
	   recently added item is last.

* Items can be looked up by index, which counts from zero.

* Items in the list are unique, so duplicate insertions
	   are moved rather than added.

* A recently-used-list is initially empty.

Optional extras

* Null insertions (empty strings) are not allowed.

* A bounded capacity can be specified, so there is an upper
limit to the number of items contained, with the least
recently added items dropped on overflow.

More tests

* While getting items by index, supplied index-value should be within the bounds of List [eg. if maximum item counts of list is 5 then supplied index is less than 4 as index starts from 0 (zero)]
* Negative index value not allowed [>0]
* Size limit is must if not supplied make 5 as default [0-4]
* List can be non-sizable means without upper limit list can be created [Hint-try property or constructor initializers]

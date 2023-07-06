# Grid3lib #

### Disclaimer ###

In its current iteration, this library will be more useful for constructing and maintaining gridsets than for editing existing ones.
This is because, without access to a full file spec for the Grid3 format, it will inevitably not support the full range of Grid3 functionality.

USE AT YOUR OWN RISK! If you open existing gridsets using this tool, they may lose functionality, or cease to function completely. Take regular backups of all gridsets, and always plan as though the the library will at some indeterminate point break all your stuff.

## Preamble ##

Grid3 is a fantastic program that the author first came across through his daughter's AAC (Augmentative & Alternative Communication) device. With an excellent editing program for Windows, it's easy to make gridsets manually - but there was no provision for automation, and in particular for integration with other systems.
Out of this need the idea for Grid3lib was born.

Gridset files are compressed using standard ZIP compression, and contain a set of XML documents and associated files in a reasonably predictable folder structure.
This library attempts to make reading and writing these zipped files significantly easier. Bulk operations which are otherwise cumbersome using the standard Grid3 software can also be achieved more efficiently.

## Current functionality ##

* Reads .gridset files into memory
* Stores the whole gridset as a tree of IXmlNodes
* Uses lazy-loading by default to keep code as responsive as possible
* Allows for writing gridset back to file _currently minus any media files_ (although that's currently in progress)
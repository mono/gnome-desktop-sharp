SUBDIRS = . glue

if ENABLE_VTE
pkg = vte
pkgversion = 0.16
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = vte-sharp-0.16.pc
else
pkg = 
endif

API_VERSION = 0.16.0.0
INCLUDE_API = 
METADATA = Vte.metadata
SYMBOLS =
references = 
glue_includes = vte/vte.h

sources = 

customs =

add_dist = vte-sharp-0.16.pc.in

include ../Makefile.include


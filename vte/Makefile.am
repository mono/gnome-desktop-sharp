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
glue_args = --glue-includes=vte/vte.h --gluelib-name=vtesharpglue-2 --glue-filename=glue/generated.c

sources = 

customs =

add_dist = vte-sharp-0.16.pc.in

include ../Makefile.include


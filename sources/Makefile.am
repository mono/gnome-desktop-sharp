EXTRA_DIST =				\
	gtkhtml-font-style-enum.patch	\
	sources-2.20.xml


GNOME_2_20_DOWNLOADS = \
	http://ftp.gnome.org/pub/GNOME/desktop/2.20/2.20.0/sources/gnome-desktop-2.20.0.tar.bz2 \
	http://ftp.gnome.org/pub/GNOME/desktop/2.20/2.20.0/sources/libgtop-2.20.0.tar.bz2	\
	http://ftp.gnome.org/pub/GNOME/desktop/2.20/2.20.0/sources/nautilus-cd-burner-2.20.0.tar.bz2

api: api-2.20

api-2.20:
	$(GAPI_PARSER) sources-2.20.xml

get-source-code: get-2.20-sources get-gtkhtml-code

get-2.20-sources:
	for i in $(GNOME_2_20_DOWNLOADS); do                  \
		wget $$i --output-document=- | tar -xj ;   \
	done;

GTKHTML_SOURCEFILES = \
        gtkhtml-3.16.0/src/gtkhtml.c \
        gtkhtml-3.16.0/src/gtkhtml.h \
        gtkhtml-3.16.0/src/gtkhtml-types.h \
        gtkhtml-3.16.0/src/gtkhtml-enums.h \
        gtkhtml-3.16.0/src/gtkhtml-embedded.c \
        gtkhtml-3.16.0/src/gtkhtml-embedded.h \
        gtkhtml-3.16.0/src/gtkhtml-stream.c \
        gtkhtml-3.16.0/src/gtkhtml-stream.h

get-gtkhtml-code:
	wget http://ftp.gnome.org/pub/GNOME/desktop/2.20/2.20.0/sources/gtkhtml-3.16.0.tar.bz2 --output-document=- | tar -xj $(GTKHTML_SOURCEFILES)
	patch -p0 < gtkhtml-font-style-enum.patch


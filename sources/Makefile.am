EXTRA_DIST =				\
	gtkhtml-font-style-enum.patch	\
	sources.xml


GNOME_DOWNLOADS = \
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/gnome-desktop-2.23.5.tar.bz2 \
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/gnome-panel-2.23.5.tar.bz2 \
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/gtksourceview-2.2.2.tar.bz2	\
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/libgnomeprint-2.18.4.tar.bz2	\
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/libgnomeprintui-2.18.2.tar.bz2	\
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/librsvg-2.22.2.tar.bz2	\
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/libwnck-2.23.4.tar.bz2	\
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/vte-0.16.14.tar.bz2		\
	http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/nautilus-cd-burner-2.22.1.tar.bz2

api:
	$(GAPI_PARSER) sources.xml

get-source-code: get-gnome-sources get-gtkhtml-code

get-gnome-sources:
	for i in $(GNOME_DOWNLOADS); do                  \
		wget $$i --output-document=- | tar -xj ;   \
	done;

GTKHTML_SOURCEFILES = \
        gtkhtml-3.23.5/gtkhtml/gtkhtml.c \
        gtkhtml-3.23.5/gtkhtml/gtkhtml.h \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-types.h \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-enums.h \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-embedded.c \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-embedded.h \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-search.c \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-search.h \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-stream.c \
        gtkhtml-3.23.5/gtkhtml/gtkhtml-stream.h

get-gtkhtml-code:
	wget http://ftp.gnome.org/pub/GNOME/desktop/2.23/2.23.5/sources/gtkhtml-3.23.5.tar.bz2 --output-document=- | tar -xj $(GTKHTML_SOURCEFILES)
	patch -p0 < gtkhtml-font-style-enum.patch


#!/usr/bin/zsh
for type in $(grep -oP 'public class \K\w+' $@);
do
	sed -n "/public class $type /,/}/p" $@;
done

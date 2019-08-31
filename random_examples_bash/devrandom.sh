#!/bin/bash

#Generate one line of random bytes
head -1 /dev/urandom > randbytes.txt

iByteCount=0

ord() {
#  LC_CTYPE=C printf '%d' "'$1"
  irand=`printf '%d' "'$1"`

  if ((irand < 0)); then
    irand="$(($irand+256))"
  fi

  printf 'Byte: %d %s ASCII value %d\n' "$iByteCount" "'$1" "$irand"
  printf 'Six sided die: Rolled a %d\n' "$(($irand % 6 + 1))"
  printf 'Twenty sided die: Rolled a %d\n\n' "$(($irand % 20 + 1))"

}

while IFS= read -r -n1 char
do

  iByteCount="$(($iByteCount + 1))"

#  echo "$char"
  ord $char
done < randbytes.txt

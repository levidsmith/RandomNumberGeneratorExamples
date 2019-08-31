#!/bin/bash
systime_millis=`date +%s%3N`
echo $systime_millis
randnum1=$((1 + systime_millis % 100))
randnum2=$((1 + systime_millis %52))
echo "Random number between 1 and 100: "$randnum1
echo "Random number between 1 and 52: "$randnum2

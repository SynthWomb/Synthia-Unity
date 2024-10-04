@echo off
echo Adding the remote repository 'synthia'...
git remote add synthia https://github.com/SynthWomb/Synthia-Unity.git

echo Fetching from 'synthia'...
git fetch synthia

echo Checking out the 'main' branch...
git checkout main

echo Merging 'synthia/main' into 'main' with unrelated histories allowed...
git merge synthia/main --allow-unrelated-histories

echo Committing the merge...
git commit -m "Merged from Synthia-Unity repository"

echo Process complete!
pause
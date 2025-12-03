
```bash
git init
git remote add origin https://github.com/maks8823/Practice.git
git remote -v
git add .
git commit -m "Initial commit"
git branch -m master main
git push -u origin main

git checkout -b homework-1
rm -rf homework2 homework3 homework4 homework5 homework6 homework8
mv homework1/* .
mv homework1/.* . 2>/dev/null || true
rmdir homework1
rm -f README.md
git add .
git commit -m "homework-1"
git push origin homework-1
git checkout main

git checkout -b homework-2
rm -rf homework1 homework3 homework4 homework5 homework6 homework8
mv homework2/* .
mv homework2/.* . 2>/dev/null || true
rmdir homework2
rm -f README.md
git add .
git commit -m "homework-2"
git push origin homework-2
git checkout main

git checkout -b homework-3
rm -rf homework1 homework2 homework4 homework5 homework6 homework8
mv homework3/* .
mv homework3/.* . 2>/dev/null || true
rmdir homework3
rm -f README.md
git add .
git commit -m "homework-3"
git push origin homework-3
git checkout main

git checkout -b homework-4
rm -rf homework1 homework2 homework3 homework5 homework6 homework8
mv homework4/* .
mv homework4/.* . 2>/dev/null || true
rmdir homework4
rm -f README.md
git add .
git commit -m "homework-4"
git push origin homework-4
git checkout main

git checkout -b homework-5
rm -rf homework1 homework2 homework3 homework4 homework6 homework8
mv homework5/* .
mv homework5/.* . 2>/dev/null || true
rmdir homework5
rm -f README.md
git add .
git commit -m "homework-5"
git push origin homework-5
git checkout main

git checkout -b homework-6
rm -rf homework1 homework2 homework3 homework4 homework5 homework8
mv homework6/* .
mv homework6/.* . 2>/dev/null || true
rmdir homework6
rm -f README.md
git add .
git commit -m "homework-6"
git push origin homework-6
git checkout main

git checkout -b homework-8
rm -rf homework1 homework2 homework3 homework4 homework5 homework6
mv homework8/* .
mv homework8/.* . 2>/dev/null || true
rmdir homework8
rm -f README.md
git add .
git commit -m "homework-8"
git push origin homework-8
git checkout main

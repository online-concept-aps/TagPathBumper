# Tag Path Bumper

```powershell
    $version = "0.0.3"
    git add .
    git commit -m "commit message"
    git tag -a -m "My third action release" "v$version"
    git push -u origin main --follow-tags
```

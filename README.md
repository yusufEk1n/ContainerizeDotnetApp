## Containerize a .NET App

Demonstration of .net on docker for console app.

## How does it work?

Open terminal in the directory containing the Dockerfile. 

Run the following command

```bash
docker build -t <image-name> -f Dockerfile .
```

Create the new container using following command

```
docker create --name <container-name> <image-name>
```

Start the container

```
docker start --attach <container-name>
```
## Container Working Tree

📁 App
&nbsp;&nbsp;&nbsp;├── DotNet.Docker
&nbsp;&nbsp;&nbsp;├── DotNet.Docker.deps.json
&nbsp;&nbsp;&nbsp;├── DotNet.Docker.dll
&nbsp;&nbsp;&nbsp;├── DotNet.Docker.pdb
&nbsp;&nbsp;&nbsp;├── DotNet.Docker.runtimeconfig.json
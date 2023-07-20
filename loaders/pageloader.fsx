#r "../_lib/Fornax.Core.dll"
#load "globalloader.fsx"

type Page = {
    title: string
    link: string
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    let siteRoot = 
        siteContent.TryGetValue<Globalloader.SiteInfo> ()
        |> Option.map(fun si -> si.siteRoot)
        |> Option.defaultValue "/"

    siteContent.Add({title = "Home"; link = siteRoot})
    siteContent.Add({title = "About"; link = $"{siteRoot}/about.html"})
    // siteContent.Add({title = "Contact"; link = $"{siteRoot}/contact.html"})

    siteContent

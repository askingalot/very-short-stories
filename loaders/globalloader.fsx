#r "../_lib/Fornax.Core.dll"

type SiteInfo = {
    title: string
    description: string
    postPageSize: int
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    let siteInfo =
        { title = "Andy's Very Short Stories";
          description = "Very Short Stories"
          postPageSize = 20 }
    siteContent.Add(siteInfo)

    siteContent

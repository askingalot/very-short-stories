#r "../_lib/Fornax.Core.dll"

type SiteInfo = {
    title: string
    description: string
    postPageSize: int
    siteRoot: string
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    let siteInfo =
        { title = "Andy's Very Short Stories"
          description = "Very Short Stories"
          postPageSize = 20
          siteRoot = "/very-short-stories" }
    siteContent.Add(siteInfo)

    siteContent

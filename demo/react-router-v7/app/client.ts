import { createSymxifyClient } from "symxify-client";

export const symxify = createSymxifyClient({
  symxifyUrl: "https://localhost:7036/api/v1/symxchange",
  symxifyKey: process.env.SYMXIFY_KEY,
})


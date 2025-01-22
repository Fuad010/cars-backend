import ky from "ky";

export const httpClient = ky.create({
    prefixUrl:"https://localhost:44322/api/"
})
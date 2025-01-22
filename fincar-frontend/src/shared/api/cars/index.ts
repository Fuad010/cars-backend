import { httpClient } from "../http-client"
import { Car, QueryParams } from "./model"
 
const SLUG = "car"

export const getCar = (params: QueryParams ) =>
    httpClient.get(SLUG, {searchParams: params}).json<Car[]>();

export const getCarById = (id: string) =>
    httpClient.get(`${SLUG}/${id}`).json<Car>();

export const updateCar = (car: Car) => 
    httpClient.put(`${SLUG}/${car.id}`, { json: car }).json<Car>();
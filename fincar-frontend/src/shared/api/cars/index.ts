import { httpClient } from "../http-client"
import { Car, CarObject } from "./model"
 
const SLUG = "car"

export const getCars = (count?: number) => {
    const url = count ? `${SLUG}?count=${count}` : SLUG;
    return httpClient.get(url).json<CarObject>();
};

export const getCarById = (id: string) =>
    httpClient.get(`${SLUG}/${id}`).json<Car>();

export const updateCar = (car: Car) => 
    httpClient.put(`${SLUG}/${car.id}`, { json: car }).json<Car>();
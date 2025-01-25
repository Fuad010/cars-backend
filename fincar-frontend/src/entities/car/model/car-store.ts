import { makeAutoObservable, runInAction } from "mobx";
import { getCars, getCarById, updateCar } from "shared/api/cars";
import { Car } from "shared/api/cars/model";

class CarStore {
    carList: Car[] = [];
    car?: Car;
    isLoading = false;
    carListError = '';
    carError = '';
    isUpdateLoading = false;

    constructor() {
        makeAutoObservable(this)
    }

    getCarList = async (count?:number) => {
            try {
            this.isLoading = true;
            const data = await getCars(count);

            runInAction(() =>{
                this.isLoading = false;
                this.carList = data.cars;
            })
            
        } catch (error) {
            if (error instanceof Error) {
                runInAction(() => {
                    this.isLoading = false;
                    this.carListError = error.message as string
                })
            }
        }
    }

    getCar = async (id: string) => 
    {
        try {
            this.isLoading = true;

            const data = await getCarById(id);
            
            runInAction(() =>{
                this.isLoading = false;
                this.car = data
            });
        } catch (error) {
            if (error instanceof Error) {
                runInAction(() => {
                    this.isLoading = false;
                    this.carListError = error.message as string
                })
            }
        }
    }

    updateCar = async (car: Car) => {
        try{
            this.isUpdateLoading = true;
            await updateCar(car);
            
            this.isUpdateLoading = false;
        } catch (error) {
            this.isUpdateLoading = false;
            throw error;
        }
    }
}

export const store = new CarStore();
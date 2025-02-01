import { makeAutoObservable, runInAction } from "mobx";
import { getCars, getCarById, updateCar } from "shared/api/cars";
import { Car } from "shared/api/cars/model";

class CarStore {
    carList: Car[] = [];
    carListLimited: Car[] = [];
    car?: Car;
    isLoading = false;
    carListError = '';
    carError = '';
    isExistCar = false;
    isUpdateLoading = false;

    constructor() {
        makeAutoObservable(this)
    }

    getCarList = async () => {
        try {
        this.isLoading = true;
        
        const data = await getCars();

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

    getCarListLimited = async (count:number) => {
        try {
        this.isLoading = true;
        
        const data = await getCars(count);

        runInAction(() =>{
            this.isLoading = false;
            this.carListLimited = data.cars;
            
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

    getCar = async (id: string) => {
        try {
            this.isExistCar = false
            this.isLoading = true;
            const data = await getCarById(id);
            runInAction(() => {
                this.isLoading = false;
                this.car = data;
                this.isExistCar = false;
            });
        } catch (error) {
            runInAction(() => {
                this.isLoading = false;
                this.isExistCar = true;
        });
        }
    };

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
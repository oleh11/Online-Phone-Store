import { Component } from '@angular/core';
import { Repository } from "../models/repository";

@Component({
    selector: "category-filter",
    templateUrl: "categoryFilter.component.html"
})
export class CategoryFilterComponent {
    public chessCategory = "chess";

    constructor(private repo: Repository) { }

    get categories(): string[] {
        return this.repo.categories;
    }
    get currentCategory(): string {
        return this.repo.filter.category;
    }
    setCurrentCategory(newCategory: string) {
        this.repo.filter.category = newCategory;
        this.repo.getProducts();
    }
}
